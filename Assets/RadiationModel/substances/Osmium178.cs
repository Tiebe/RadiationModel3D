using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Osmium178 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium178";
        public override double halfLife { get; } = 300.0d;
        public override double atomicWeight { get; } = 177.95325d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tungsten178()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tungsten174()), new(1.0d, new AlphaParticle(5280002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    