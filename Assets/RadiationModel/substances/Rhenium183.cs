using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium183 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium183";
        public override double halfLife { get; } = 6048000.0d;
        public override double atomicWeight { get; } = 182.95082d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tungsten183()), new(0.000272d, new GammaParticle(40976.0, 0.03026)), new(0.0799d, new GammaParticle(46484.0, 0.02667)), new(0.023732000000000003d, new GammaParticle(52596.0, 0.02357)), new(0.003128d, new GammaParticle(82919.0, 0.01495)), new(0.010438000000000001d, new GammaParticle(84712.0, 0.01464)), new(0.029138d, new GammaParticle(99080.0, 0.01251)), new(0.00018700000000000002d, new GammaParticle(101930.0, 0.01216)), new(5.78e-05d, new GammaParticle(103100.0, 0.01203)), new(0.023392d, new GammaParticle(107933.0, 0.01149)), new(0.031110000000000002d, new GammaParticle(109731.0, 0.0113)), new(3.332e-05d, new GammaParticle(120370.0, 0.0103)), new(0.001377d, new GammaParticle(144135.0, 0.0086)), new(0.006324d, new GammaParticle(160532.0, 0.00772)), new(0.003876d, new GammaParticle(161342.0, 0.00768)), new(0.25058d, new GammaParticle(162330.0, 0.00764)), new(0.0028152d, new GammaParticle(192646.0, 0.00644)), new(0.00043180000000000003d, new GammaParticle(203269.0, 0.0061)), new(0.001326d, new GammaParticle(205081.0, 0.00605)), new(0.031926d, new GammaParticle(208812.0, 0.00594)), new(0.0028186d, new GammaParticle(209890.0, 0.00591)), new(0.00442d, new GammaParticle(244266.0, 0.00508)), new(0.00272d, new GammaParticle(245243.0, 0.00506)), new(0.014178d, new GammaParticle(246062.0, 0.00504)), new(0.034d, new GammaParticle(291723.0, 0.00425)), new(0.0044846d, new GammaParticle(313021.0, 0.00396)), new(0.0057799999999999995d, new GammaParticle(353998.0, 0.0035)), new(0.0008636000000000001d, new GammaParticle(365614.0, 0.00339)), new(0.0003502d, new GammaParticle(406593.0, 0.00305)), new(0.58d, new GammaParticle(9740.0, 0.12729)), new(0.35100000000000003d, new GammaParticle(57983.0, 0.02138)), new(0.61d, new GammaParticle(59320.0, 0.0209)), new(0.20199999999999999d, new GammaParticle(67335.0, 0.01841)), new(0.257d, new GammaParticle(68117.0, 0.0182)), new(0.055d, new GammaParticle(69068.0, 0.01795)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    