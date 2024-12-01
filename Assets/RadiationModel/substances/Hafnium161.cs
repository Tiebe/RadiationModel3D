using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Hafnium161 : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium161";
        public override double halfLife { get; } = 18.4d;
        public override double atomicWeight { get; } = 160.95028d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9987d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Ytterbium161()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.0013d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Ytterbium157()), new(1.0d, new AlphaParticle(5701002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    