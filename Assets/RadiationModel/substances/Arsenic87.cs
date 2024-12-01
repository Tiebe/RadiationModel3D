using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Arsenic87 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic87";
        public override double halfLife { get; } = 0.484d;
        public override double atomicWeight { get; } = 86.94029d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Selenium87()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.154d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Selenium87()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    