using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium224 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium224";
        public override double halfLife { get; } = 1.04d;
        public override double atomicWeight { get; } = 224.02147d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radium220() }, { 1.0d, new AlphaParticle(8321002.09) }, { 0.09d, new GammaParticle(177000.0, 0.007) }, { 0.004d, new GammaParticle(235000.0, 0.00528) }, { 0.003d, new GammaParticle(297000.0, 0.00417) }, { 0.008d, new GammaParticle(410000.0, 0.00302) }, { 0.0283530242696d, new GammaParticle(14920.0, 0.0831) }, { 0.005323981209453249d, new GammaParticle(85432.0, 0.01451) }, { 0.008696473716846209d, new GammaParticle(88471.0, 0.01401) }, { 0.0030511381579070352d, new GammaParticle(100119.0, 0.01238) }, { 0.004051911473700543d, new GammaParticle(101370.0, 0.01223) }, { 0.0010007733157935076d, new GammaParticle(102948.0, 0.01204) } } },

        };
    }
}
    