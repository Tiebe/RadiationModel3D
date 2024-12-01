using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Francium209 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium209";
        public override double halfLife { get; } = 50.5d;
        public override double atomicWeight { get; } = 208.99594d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.89d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Astatine205()), new(1.0d, new AlphaParticle(7800002.09)) } },
            { 0.11d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Astatine209()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    