using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium206m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium206m";
        public override double halfLife { get; } = 224.4d;
        public override double atomicWeight { get; } = 205.97895d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thallium206() }, { 0.001032d, new GammaParticle(88500.0, 0.01401) }, { 0.7395999999999999d, new GammaParticle(216400.0, 0.00573) }, { 0.08428000000000001d, new GammaParticle(247200.0, 0.00502) }, { 0.86d, new GammaParticle(265700.0, 0.00467) }, { 0.0129d, new GammaParticle(304900.0, 0.00407) }, { 0.00774d, new GammaParticle(316800.0, 0.00391) }, { 0.010320000000000001d, new GammaParticle(368200.0, 0.00337) }, { 0.9288d, new GammaParticle(453300.0, 0.00274) }, { 0.2236d, new GammaParticle(457200.0, 0.00271) }, { 0.01376d, new GammaParticle(535500.0, 0.00232) }, { 0.05504d, new GammaParticle(564200.0, 0.0022) }, { 0.010320000000000001d, new GammaParticle(604300.0, 0.00205) }, { 0.0051600000000000005d, new GammaParticle(616300.0, 0.00201) }, { 0.9116d, new GammaParticle(686500.0, 0.00181) }, { 0.01462d, new GammaParticle(704600.0, 0.00176) }, { 0.688d, new GammaParticle(1021500.0, 0.00121) }, { 0.059340000000000004d, new GammaParticle(1139900.0, 0.00109) }, { 0.2044756398002536d, new GammaParticle(12148.0, 0.10206) }, { 0.11360994902328153d, new GammaParticle(70832.0, 0.0175) }, { 0.1917791171898743d, new GammaParticle(72874.0, 0.01701) }, { 0.0652218745883147d, new GammaParticle(82629.0, 0.015) }, { 0.08459277134104416d, new GammaParticle(83631.0, 0.01483) }, { 0.019370896752729464d, new GammaParticle(84866.0, 0.01461) } } },

        };
    }
}
    