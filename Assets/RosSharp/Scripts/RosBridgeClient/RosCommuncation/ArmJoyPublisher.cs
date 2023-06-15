/*
City, University of London
Script is written by Mahmoud Abdulsalam (mahmoud.abdulsalam@city.ac.uk).
Please Use with Permission Otherwise, Cite accordingly 
Regards
*/

using Valve.VR;

namespace RosSharp.RosBridgeClient
{
    public class ArmJoyPublisher : UnityPublisher<MessageTypes.Sensor.Joy>
    {
        //private ArmJoyAxis[] ArmReaders;
        
        public string FrameId = "Unity";

        private MessageTypes.Sensor.Joy message;

    

        protected override void Start()
        {
            base.Start();
            InitializeGameObject();
            InitializeMessage();
        }

        private void Update()
        {
            UpdateMessage();
        }

        private void InitializeGameObject()
        {
            //ArmReaders = GetComponents<ArmJoyAxis>();
            //ArmReaders = GetComponents<ArmJoyAxis>();
            //ArmReaders = ArmReaders.GetComponent<ArmJoyAxis>();

            

        }

        private void InitializeMessage()
        {
            message = new MessageTypes.Sensor.Joy();
            message.header.frame_id = FrameId;
           
            message.axes = new float[10];
          


        }

        private void UpdateMessage()
        {
            message.header.Update();

           // message.axes = new float[4] {0,0,0,0};
            bool Up = SteamVR_Actions.default_Upper.GetState(SteamVR_Input_Sources.RightHand);
            bool Down = SteamVR_Actions.default_Downer.GetState(SteamVR_Input_Sources.RightHand);
            bool Left = SteamVR_Actions.default_Lefter.GetState(SteamVR_Input_Sources.RightHand);
            bool Right = SteamVR_Actions.default_Righter.GetState(SteamVR_Input_Sources.RightHand);
            bool Func = SteamVR_Actions.default_Fn.GetState(SteamVR_Input_Sources.RightHand);
            bool Grip = SteamVR_Actions.default_Gripper.GetState(SteamVR_Input_Sources.RightHand);




            message.axes[0] = 0;
            message.axes[1] = 0;
            message.axes[2] = 0;
            message.axes[3] = 0;
            message.axes[4] = 0;
            message.axes[5] = 0;
            message.axes[6] = 0;
            message.axes[7] = 0;
            message.axes[8] = 0;
            message.axes[9] = 0;



            if (Up && !(Func))
            {
                message.axes[0] = 1;
                message.axes[1] = 0;
                message.axes[2] = 0;
                message.axes[3] = 0;
                message.axes[4] = 0;
                message.axes[5] = 0;
                message.axes[6] = 0;
                message.axes[7] = 0;


            }

            else if (Down && !(Func))
            {
                message.axes[0] = 0;
                message.axes[1] = 1;
                message.axes[2] = 0;
                message.axes[3] = 0;
                message.axes[4] = 0;
                message.axes[5] = 0;
                message.axes[6] = 0;
                message.axes[7] = 0;

            }

            else if (Left && !(Func))
            {
                message.axes[0] = 0;
                message.axes[1] = 0;
                message.axes[2] = 1;
                message.axes[3] = 0;
                message.axes[4] = 0;
                message.axes[5] = 0;
                message.axes[6] = 0;
                message.axes[7] = 0;

            }

            else if (Right && !(Func))
            {
                message.axes[0] = 0;
                message.axes[1] = 0;
                message.axes[2] = 0;
                message.axes[3] = 1;
                message.axes[4] = 0;
                message.axes[5] = 0;
                message.axes[6] = 0;
                message.axes[7] = 0;

            }

            else if (Func && Up )
            {
                message.axes[0] = 0;
                message.axes[1] = 0;
                message.axes[2] = 0;
                message.axes[3] = 0;
                message.axes[4] = 1;
                message.axes[5] = 0;
                message.axes[6] = 0;
                message.axes[7] = 0;

            }

            else if (Func && Down)
            {
                message.axes[0] = 0;
                message.axes[1] = 0;
                message.axes[2] = 0;
                message.axes[3] = 0;
                message.axes[4] = 0;
                message.axes[5] = 1;
                message.axes[6] = 0;
                message.axes[7] = 0;

            }

            else if (Func && Left)
            {
                message.axes[0] = 0;
                message.axes[1] = 0;
                message.axes[2] = 0;
                message.axes[3] = 0;
                message.axes[4] = 0;
                message.axes[5] = 0;
                message.axes[6] = 1;
                message.axes[7] = 0;

            }

            else if (Func && Right)
            {
                message.axes[0] = 0;
                message.axes[1] = 0;
                message.axes[2] = 0;
                message.axes[3] = 0;
                message.axes[4] = 0;
                message.axes[5] = 0;
                message.axes[6] = 0;
                message.axes[7] = 1;

            }

            else if (Grip && !(Func))
                message.axes[8] = 1;

            else if (Func && Grip)
                message.axes[9] = 1;

            else
            {
                message.axes[0] = 0;
                message.axes[1] = 0;
                message.axes[2] = 0;
                message.axes[3] = 0;
                message.axes[4] = 0;
                message.axes[5] = 0;
                message.axes[6] = 0;
                message.axes[7] = 0;
                message.axes[8] = 0;
                message.axes[9] = 0;
            }
            //message.axes[i] = ArmReaders[i].Doer();






            Publish(message);
        }
    }
}
