using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium174 : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium174";
        public override double halfLife { get; } = 104453424.9759d;
        public override double atomicWeight { get; } = 173.94034d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thulium174() }, { 1.0d, new BetaParticle(1, -855150.00001) }, { 0.0592642d, new GammaParticle(76468.0, 0.01621) }, { 0.00010794d, new GammaParticle(176653.0, 0.00702) }, { 0.00016448d, new GammaParticle(1065040.0, 0.00116) }, { 0.051399999999999994d, new GammaParticle(1241847.0, 0.001) }, { 0.00035465999999999997d, new GammaParticle(1318296.0, 0.00094) }, { 0.000476d, new GammaParticle(511000.0, 0.00243) }, { 0.29675716267291385d, new GammaParticle(8502.0, 0.14583) }, { 0.2376488467861554d, new GammaParticle(51354.0, 0.02414) }, { 0.41891212195691063d, new GammaParticle(52389.0, 0.02367) }, { 0.13750812993262784d, new GammaParticle(59481.0, 0.02084) }, { 0.17339775184504372d, new GammaParticle(60151.0, 0.02061) }, { 0.03588962191241587d, new GammaParticle(60961.0, 0.02034) } } },

        };
    }
}
    