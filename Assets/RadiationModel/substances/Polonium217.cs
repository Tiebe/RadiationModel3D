using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Polonium217 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium217";
        public override double halfLife { get; } = 1.53d;
        public override double atomicWeight { get; } = 217.00632d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.95d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lead213()), new(1.0d, new AlphaParticle(7684002.09)) } },
            { 0.05d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Astatine217()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    