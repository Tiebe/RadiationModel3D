using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Polonium215 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium215";
        public override double halfLife { get; } = 0.00178d;
        public override double atomicWeight { get; } = 214.99942d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9999977d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lead211()), new(1.0d, new AlphaParticle(8548202.09)) } },
            { 2.3e-06d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Astatine215()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    