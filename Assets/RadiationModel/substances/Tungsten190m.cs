using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tungsten190m : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten190m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 189.96497d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tungsten190()), new(0.038d, new GammaParticle(102000.0, 0.01216)), new(0.784d, new GammaParticle(206800.0, 0.006)), new(0.9515d, new GammaParticle(358300.0, 0.00346)), new(0.9777d, new GammaParticle(484300.0, 0.00256)), new(0.20600000000000002d, new GammaParticle(593600.0, 0.00209)), new(0.785d, new GammaParticle(694000.0, 0.00179)), new(0.106620778849175d, new GammaParticle(9740.0, 0.12729)), new(0.08845199674968525d, new GammaParticle(57983.0, 0.02138)), new(0.15364251650110342d, new GammaParticle(59320.0, 0.0209)), new(0.05092726024427893d, new GammaParticle(67335.0, 0.01841)), new(0.06488132955121136d, new GammaParticle(68117.0, 0.0182)), new(0.013954069306932427d, new GammaParticle(69068.0, 0.01795)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    