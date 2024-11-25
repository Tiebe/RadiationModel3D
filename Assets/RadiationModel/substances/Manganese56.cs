using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese56 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese56";
        public override double halfLife { get; } = 9284.04d;
        public override double atomicWeight { get; } = 55.9389d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iron56() }, { 1.0d, new BetaParticle(-1, 1847745.0) }, { 0.9884999999999999d, new GammaParticle(846763.8, 0.00146) }, { 0.00039539999999999996d, new GammaParticle(1037833.3, 0.00119) }, { 0.00039539999999999996d, new GammaParticle(1238273.6, 0.001) }, { 0.268872d, new GammaParticle(1810726.0, 0.00068) }, { 0.142344d, new GammaParticle(2113092.0, 0.00059) }, { 0.01018155d, new GammaParticle(2523060.0, 0.00049) }, { 0.00019769999999999998d, new GammaParticle(2598438.0, 0.00048) }, { 0.0064549049999999995d, new GammaParticle(2657560.0, 0.00047) }, { 0.00306435d, new GammaParticle(2959920.0, 0.00042) }, { 0.00168045d, new GammaParticle(3369810.0, 0.00037) }, { 2.608324496501562e-06d, new GammaParticle(728.0, 1.70308) }, { 2.97463718290505e-05d, new GammaParticle(6391.0, 0.194) }, { 5.8246273407187194e-05d, new GammaParticle(6404.0, 0.1936) }, { 1.2037393868317317e-05d, new GammaParticle(7082.0, 0.17507) }, { 1.2037393868317317e-05d, new GammaParticle(7082.0, 0.17507) } } },

        };
    }
}
    