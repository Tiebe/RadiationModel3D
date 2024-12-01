using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Bismuth222 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth222";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 222.03108d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Polonium222()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    