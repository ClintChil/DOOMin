﻿using UnityEngine;
using System.Collections;
using EasyWiFi.Core;
using System;

namespace EasyWiFi.ServerControls
{

    [AddComponentMenu("EasyWiFiController/Server/DataControls/Custom Int")]
    public class CustomIntDataServerController : MonoBehaviour, IServerController
    {

        public string control = "IntData1";
        public EasyWiFiConstants.PLAYER_NUMBER player = EasyWiFiConstants.PLAYER_NUMBER.Player1;
        public string notifyMethod = "yourMethod";


        //runtime variables
        //we reuse the backchannel data types even though this is a forward channel
        IntBackchannelType[] intController = new IntBackchannelType[EasyWiFiConstants.MAX_CONTROLLERS];
        int currentNumberControllers = 0;

        void OnEnable()
        {
            EasyWiFiController.On_ConnectionsChanged += checkForNewConnections;

            //do one check at the beginning just in case we're being spawned after startup and after the callbacks
            //have already been called
            if (intController[0] == null && EasyWiFiController.lastConnectedPlayerNumber >= 0)
            {
                EasyWiFiUtilities.checkForClient(control, (int)player, ref intController, ref currentNumberControllers);
            }
        }

        void OnDestroy()
        {
            EasyWiFiController.On_ConnectionsChanged -= checkForNewConnections;
        }

        // Update is called once per frame
        void Update()
        {
            //iterate over the current number of connected controllers
            for (int i = 0; i < currentNumberControllers; i++)
            {
                if (intController[i] != null && intController[i].serverKey != null && intController[i].logicalPlayerNumber != EasyWiFiConstants.PLAYERNUMBER_DISCONNECTED)
                {
                    mapDataStructureToAction(i);
                }
            }
        }


        public void mapDataStructureToAction(int index)
        {
            SendMessage(notifyMethod, intController[index], SendMessageOptions.DontRequireReceiver);
        }

        public void checkForNewConnections(bool isConnect, int playerNumber)
        {
            EasyWiFiUtilities.checkForClient(control, (int)player, ref intController, ref currentNumberControllers);
        }
    }

}
