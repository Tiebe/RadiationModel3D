using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Osmium197 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium197";
        public override double halfLife { get; } = 168.0d;
        public override double atomicWeight { get; } = 196.97308d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iridium197()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    