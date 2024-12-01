using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Beryllium10i : RadioactiveSubstance
    {
        public override string name { get; } = "Beryllium10i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 10.03627d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Beryllium9()), new(1.0d, new NeutronParticle()) } },
            { 0.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lithium9()), new(1.0d, new ProtonParticle()) } },
            { 0.0d, new List<KeyValuePair<double, RadioactiveSubstance>> {  } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    