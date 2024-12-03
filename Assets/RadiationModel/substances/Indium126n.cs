using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Indium126n : RadioactiveSubstance
    {
        public override string name { get; } = "Indium126n";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 125.91673d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Indium126()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    