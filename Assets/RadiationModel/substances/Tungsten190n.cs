using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tungsten190n : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten190n";
        public override double halfLife { get; } = 0.00017d;
        public override double atomicWeight { get; } = 189.96508d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tungsten190()), new(0.0204d, new GammaParticle(97000.0, 0.01278)), new(0.038d, new GammaParticle(102000.0, 0.01216)), new(0.784d, new GammaParticle(206800.0, 0.006)), new(0.9515d, new GammaParticle(358300.0, 0.00346)), new(0.9777d, new GammaParticle(484300.0, 0.00256)), new(0.204d, new GammaParticle(593600.0, 0.00209)), new(0.785d, new GammaParticle(694000.0, 0.00179)), new(0.330340329633175d, new GammaParticle(9740.0, 0.12729)), new(0.27518122615865254d, new GammaParticle(57983.0, 0.02138)), new(0.47799413958424963d, new GammaParticle(59320.0, 0.0209)), new(0.1584387739553358d, new GammaParticle(67335.0, 0.01841)), new(0.20185099801909778d, new GammaParticle(68117.0, 0.0182)), new(0.043412224063762d, new GammaParticle(69068.0, 0.01795)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    