using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Molybdenum100 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum100";
        public override double halfLife { get; } = 2.212140510818899e+26d;
        public override double atomicWeight { get; } = 99.90747d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Ruthenium100()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Ruthenium100()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    