using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tantalum157 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum157";
        public override double halfLife { get; } = 0.0101d;
        public override double atomicWeight { get; } = 156.96822d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.966d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lutetium153()), new(1.0d, new AlphaParticle(7377002.09)) } },
            { 0.034d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Hafnium156()), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    