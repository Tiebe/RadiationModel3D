using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium251 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium251";
        public override double halfLife { get; } = 1008.0d;
        public override double atomicWeight { get; } = 251.08229d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Berkelium251() }, { 1.0d, new BetaParticle(-1, 710000.0) }, { 0.0057399999999999994d, new GammaParticle(233600.0, 0.00531) }, { 0.00672d, new GammaParticle(311700.0, 0.00398) }, { 0.01638d, new GammaParticle(389700.0, 0.00318) }, { 0.0021d, new GammaParticle(415900.0, 0.00298) }, { 0.00924d, new GammaParticle(422300.0, 0.00294) }, { 0.00196d, new GammaParticle(435800.0, 0.00284) }, { 0.015960000000000002d, new GammaParticle(438200.0, 0.00283) }, { 0.02086d, new GammaParticle(530000.0, 0.00234) }, { 0.14d, new GammaParticle(542700.0, 0.00228) }, { 0.01316d, new GammaParticle(562500.0, 0.0022) }, { 0.00196d, new GammaParticle(945900.0, 0.00131) }, { 0.01288d, new GammaParticle(978200.0, 0.00127) }, { 0.025455158671488d, new GammaParticle(19075.0, 0.065) }, { 0.012989881997420752d, new GammaParticle(107218.0, 0.01156) }, { 0.020220862387018604d, new GammaParticle(112150.0, 0.01106) }, { 0.0076281695004140615d, new GammaParticle(126449.0, 0.00981) }, { 0.01032854150356064d, new GammaParticle(128067.0, 0.00968) }, { 0.002700372003146578d, new GammaParticle(130195.0, 0.00952) } } },

        };
    }
}
    