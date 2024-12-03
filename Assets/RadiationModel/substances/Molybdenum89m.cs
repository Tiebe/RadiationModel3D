using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Molybdenum89m : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum89m";
        public override double halfLife { get; } = 0.19d;
        public override double atomicWeight { get; } = 88.91988d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Molybdenum89()), new(0.71d, new GammaParticle(118800.0, 0.01044)), new(0.87d, new GammaParticle(268500.0, 0.00462)), new(0.0049072078386000004d, new GammaParticle(2440.0, 0.50813)), new(0.023411983696661212d, new GammaParticle(17374.0, 0.07136)), new(0.044619751661256354d, new GammaParticle(17479.0, 0.07093)), new(0.011708061214976107d, new GammaParticle(19681.0, 0.063)), new(0.013511102642082426d, new GammaParticle(19794.0, 0.06264)), new(0.0018030414271063206d, new GammaParticle(19963.0, 0.06211)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    