using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Moscovium287 : RadioactiveSubstance
    {
        public override string name { get; } = "Moscovium287";
        public override double halfLife { get; } = 0.037d;
        public override double atomicWeight { get; } = 287.19082d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Nihonium283()), new(1.0d, new AlphaParticle(11787002.09)) } },
            { 0.25d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    