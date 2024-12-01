using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Technetium97 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium97";
        public override double halfLife { get; } = 132854658353032.31d;
        public override double atomicWeight { get; } = 96.90636d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Molybdenum97()), new(0.038028238650000004d, new GammaParticle(2440.0, 0.50813)), new(0.18905495046356688d, new GammaParticle(17374.0, 0.07136)), new(0.3603105592978214d, new GammaParticle(17479.0, 0.07093)), new(0.09454418564871032d, new GammaParticle(19681.0, 0.063)), new(0.10910399023861171d, new GammaParticle(19794.0, 0.06264)), new(0.014559804589901389d, new GammaParticle(19963.0, 0.06211)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    