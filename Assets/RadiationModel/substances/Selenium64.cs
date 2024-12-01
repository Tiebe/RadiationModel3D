using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Selenium64 : RadioactiveSubstance
    {
        public override string name { get; } = "Selenium64";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 63.97116d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Germanium64()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    