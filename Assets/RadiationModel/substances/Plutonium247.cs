using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Plutonium247 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium247";
        public override double halfLife { get; } = 196128.0d;
        public override double atomicWeight { get; } = 247.0743d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Americium247()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    