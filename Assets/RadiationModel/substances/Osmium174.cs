using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Osmium174 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium174";
        public override double halfLife { get; } = 44.0d;
        public override double atomicWeight { get; } = 173.95706d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rhenium174()) } },
            { 0.0002d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tungsten170()), new(1.0d, new AlphaParticle(5893002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    