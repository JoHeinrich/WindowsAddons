//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using VoiceControl;
//namespace VoiceControl
//{
//    public class ActivationController : INamedCommandController
//    {
//        private readonly ControllerManager controllerManager;

//        public ActivationController(ControllerManager controllerManager)
//        {
//            this.controllerManager = controllerManager;
//        }
//        public string Name => "Controller";

//        public void Build(IBuilder builder)
//        {
//            foreach (var controller in controllerManager.Controllers)
//            {
//                Console.WriteLine(controller.Settings.Name);
//                builder.Commands.AddCommand("Activate " + controller.Settings.Name, () => controller.activationManager.Activation = ActivationEnum.both);
//            }
//        }
//    }
//}this && static 
