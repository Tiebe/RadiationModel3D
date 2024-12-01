using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Selenium63 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium63";
        public override double halfLife { get; } = 0.0132d;
        public override double atomicWeight { get; } = 62.98191d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Germanium63()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.89d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Germanium62()), new(1.0d, new ProtonParticle()) } },
            { 0.005d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Germanium61()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    