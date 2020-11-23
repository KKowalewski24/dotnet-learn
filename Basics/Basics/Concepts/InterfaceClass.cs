namespace Basics.Concepts {

    public class InterfaceClass : IControl, ISurface {

        /*------------------------ FIELDS REGION ------------------------*/
        string IControl.Name { get; set; }
        int ISurface.Type { get; set; }

        /*------------------------ METHODS REGION ------------------------*/
        
        
        // void IControl.Paint() {
        //     throw new System.NotImplementedException();
        // }
        //
        // void ISurface.Paint() {
        //     throw new System.NotImplementedException();
        // }

    }

}
