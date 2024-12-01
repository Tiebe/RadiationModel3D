using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Samarium138 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium138";
        public override double halfLife { get; } = 186.0d;
        public override double atomicWeight { get; } = 137.92324d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Neodymium138()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    