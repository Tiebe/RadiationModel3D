using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Silicon29 : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon29";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 28.97649d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    