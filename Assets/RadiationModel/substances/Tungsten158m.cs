using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tungsten158m : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten158m";
        public override double halfLife { get; } = 0.00014d;
        public override double atomicWeight { get; } = 157.9766d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Hafnium154()), new(1.0d, new AlphaParticle(9527002.09)) } },
            { 0.0017000000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Hafnium156()), new(1.0d, new ProtonParticle()) } },
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
    