using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium168 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium168";
        public override double halfLife { get; } = 522.0d;
        public override double atomicWeight { get; } = 167.93713d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Holmium168() }, { 1.0d, new BetaParticle(-1, 750000.0) }, { 0.044000000000000004d, new GammaParticle(43800.0, 0.02831) }, { 0.065d, new GammaParticle(143500.0, 0.00864) }, { 0.32799999999999996d, new GammaParticle(192500.0, 0.00644) }, { 0.085d, new GammaParticle(437000.0, 0.00284) }, { 0.155d, new GammaParticle(443300.0, 0.0028) }, { 0.225d, new GammaParticle(487000.0, 0.00255) }, { 0.136d, new GammaParticle(630400.0, 0.00197) }, { 0.12177304602016d, new GammaParticle(7656.0, 0.16194) }, { 0.10482343231980992d, new GammaParticle(46700.0, 0.02655) }, { 0.18668465239503104d, new GammaParticle(47547.0, 0.02608) }, { 0.06031441086123733d, new GammaParticle(53982.0, 0.02297) }, { 0.07599615768515905d, new GammaParticle(54577.0, 0.02272) }, { 0.015681746823921705d, new GammaParticle(55293.0, 0.02242) } } },

        };
    }
}
    