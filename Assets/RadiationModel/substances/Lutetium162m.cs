using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Lutetium162m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium162m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 161.94341d;

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
    