using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium130 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium130";
        public override double halfLife { get; } = 0.29d;
        public override double atomicWeight { get; } = 129.92495d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin130() }, { 1.0d, new BetaParticle(-1, 5112850.0) }, { 0.4029d, new GammaParticle(89230.0, 0.01389) }, { 0.6478d, new GammaParticle(129800.0, 0.00955) }, { 0.20224d, new GammaParticle(137960.0, 0.00899) }, { 0.02291d, new GammaParticle(219080.0, 0.00566) }, { 0.5372d, new GammaParticle(774370.0, 0.0016) }, { 0.01738d, new GammaParticle(807010.0, 0.00154) }, { 0.05056d, new GammaParticle(952590.0, 0.0013) }, { 0.11771000000000001d, new GammaParticle(952590.0, 0.0013) }, { 0.6399d, new GammaParticle(1221240.0, 0.00102) }, { 0.79d, new GammaParticle(1905170.0, 0.00065) }, { 0.06557d, new GammaParticle(1945820.0, 0.00064) }, { 0.03713d, new GammaParticle(2028340.0, 0.00061) }, { 0.054509999999999996d, new GammaParticle(2091450.0, 0.00059) }, { 0.02528d, new GammaParticle(2898500.0, 0.00043) }, { 0.023704657776800003d, new GammaParticle(3753.0, 0.33036) }, { 0.07129554711746298d, new GammaParticle(25044.0, 0.04951) }, { 0.1334372957467022d, new GammaParticle(25271.0, 0.04906) }, { 0.037731048567948906d, new GammaParticle(28579.0, 0.04338) }, { 0.04516406513583484d, new GammaParticle(28810.0, 0.04304) }, { 0.007433016567885935d, new GammaParticle(29107.0, 0.0426) } } },
            { 0.009300000000000001d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin130() }, { 1.0d, new BetaParticle(-1, 5112850.0) }, { 0.4029d, new GammaParticle(89230.0, 0.01389) }, { 0.6478d, new GammaParticle(129800.0, 0.00955) }, { 0.20224d, new GammaParticle(137960.0, 0.00899) }, { 0.02291d, new GammaParticle(219080.0, 0.00566) }, { 0.5372d, new GammaParticle(774370.0, 0.0016) }, { 0.01738d, new GammaParticle(807010.0, 0.00154) }, { 0.05056d, new GammaParticle(952590.0, 0.0013) }, { 0.11771000000000001d, new GammaParticle(952590.0, 0.0013) }, { 0.6399d, new GammaParticle(1221240.0, 0.00102) }, { 0.79d, new GammaParticle(1905170.0, 0.00065) }, { 0.06557d, new GammaParticle(1945820.0, 0.00064) }, { 0.03713d, new GammaParticle(2028340.0, 0.00061) }, { 0.054509999999999996d, new GammaParticle(2091450.0, 0.00059) }, { 0.02528d, new GammaParticle(2898500.0, 0.00043) }, { 0.023704657776800003d, new GammaParticle(3753.0, 0.33036) }, { 0.07129554711746298d, new GammaParticle(25044.0, 0.04951) }, { 0.1334372957467022d, new GammaParticle(25271.0, 0.04906) }, { 0.037731048567948906d, new GammaParticle(28579.0, 0.04338) }, { 0.04516406513583484d, new GammaParticle(28810.0, 0.04304) }, { 0.007433016567885935d, new GammaParticle(29107.0, 0.0426) } } },

        };
    }
}
    