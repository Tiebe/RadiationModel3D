using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Actinium208 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium208";
        public override double halfLife { get; } = 0.095d;
        public override double atomicWeight { get; } = 208.01155d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.99d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Francium204()), new(1.0d, new AlphaParticle(8750002.09)) } },
            { 0.01d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Radium208()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    