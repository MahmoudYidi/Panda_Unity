/*
City, University of London
Script is written by Mahmoud Abdulsalam (mahmoud.abdulsalam@city.ac.uk).
Please Use with Permission Otherwise, Cite accordingly 
Regards
*/

using UnityEngine;
using Valve.VR;

namespace RosSharp.RosBridgeClient
{
    public class ArmJoyAxis : MonoBehaviour
    {

        //float[] Controls = new float[4] { 0, 0, 0, 0 };


        bool Up = SteamVR_Actions.default_Upper.GetStateDown(SteamVR_Input_Sources.Any);
        bool Down = SteamVR_Actions.default_Downer.GetStateDown(SteamVR_Input_Sources.Any);
        bool Left = SteamVR_Actions.default_Lefter.GetStateDown(SteamVR_Input_Sources.Any);
        bool Right = SteamVR_Actions.default_Righter.GetStateDown(SteamVR_Input_Sources.Any);


        public float Doer()
        {
            //Debug.Log(UnityEngine.Input.GetJoystickNames());
            //print(SteamVR_Actions.default_MoveForwardRobot.GetAxis(SteamVR_Input_Sources.Any))

            

            //List<float> Controls = new List<float>();


            if (Up)
            {
                
                return 1;

            }

            else if (Down)
            {
            
                return 2;
            }

            else if (Left)
            {
               
                return 3;
            }

            else if (Right)
            {
                
                return 4 ;
            }
            else
            {
               
                return 0; 

            }



            //return SteamVR_Actions.default_MoveForwardRobot.GetAxis(SteamVR_Input_Sources.Any);

            //return Input.GetAxis(Name);      

        }
    }
}

