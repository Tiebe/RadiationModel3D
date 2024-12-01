using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Americium233 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium233";
        public override double halfLife { get; } = 192.0d;
        public override double atomicWeight { get; } = 233.04647d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.955d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Neptunium233()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.045d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Neptunium229()), new(1.0d, new AlphaParticle(8087002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    