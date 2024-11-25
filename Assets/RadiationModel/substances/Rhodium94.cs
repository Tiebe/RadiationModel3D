using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium94 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium94";
        public override double halfLife { get; } = 70.6d;
        public override double atomicWeight { get; } = 93.92173d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Technetium94() }, { 1.0d, new BetaParticle(1, 5625000.0) }, { 0.045d, new GammaParticle(126400.0, 0.00981) }, { 0.0085d, new GammaParticle(126400.0, 0.00981) }, { 0.75d, new GammaParticle(146100.0, 0.00849) }, { 0.12d, new GammaParticle(311700.0, 0.00398) }, { 0.973d, new GammaParticle(311700.0, 0.00398) }, { 0.0275d, new GammaParticle(438100.0, 0.00283) }, { 0.071d, new GammaParticle(438100.0, 0.00283) }, { 0.042d, new GammaParticle(492600.0, 0.00252) }, { 0.019d, new GammaParticle(552900.0, 0.00224) }, { 1.0d, new GammaParticle(756200.0, 0.00164) }, { 0.51d, new GammaParticle(756200.0, 0.00164) }, { 0.017d, new GammaParticle(1033400.0, 0.0012) }, { 0.047d, new GammaParticle(1068100.0, 0.00116) }, { 0.307d, new GammaParticle(1072500.0, 0.00116) }, { 0.028999999999999998d, new GammaParticle(1110700.0, 0.00112) }, { 1.0d, new GammaParticle(1430700.0, 0.00087) }, { 1.0d, new GammaParticle(1430700.0, 0.00087) }, { 0.0433d, new GammaParticle(1539700.0, 0.00081) }, { 0.022000000000000002d, new GammaParticle(1804300.0, 0.00069) }, { 0.022000000000000002d, new GammaParticle(1902500.0, 0.00065) }, { 0.019d, new GammaParticle(2099500.0, 0.00059) }, { 0.015d, new GammaParticle(2124500.0, 0.00058) }, { 0.011000000000000001d, new GammaParticle(2124500.0, 0.00058) }, { 0.01d, new GammaParticle(2631600.0, 0.00047) }, { 0.013999999999999999d, new GammaParticle(2631600.0, 0.00047) }, { 0.013999999999999999d, new GammaParticle(2677800.0, 0.00046) }, { 0.008d, new GammaParticle(2778600.0, 0.00045) }, { 0.011000000000000001d, new GammaParticle(2778600.0, 0.00045) }, { 0.009000000000000001d, new GammaParticle(2966000.0, 0.00042) }, { 0.01d, new GammaParticle(3007700.0, 0.00041) }, { 0.006999999999999999d, new GammaParticle(3007700.0, 0.00041) }, { 0.009000000000000001d, new GammaParticle(3210300.0, 0.00039) }, { 0.013000000000000001d, new GammaParticle(3210300.0, 0.00039) }, { 0.013999999999999999d, new GammaParticle(3256000.0, 0.00038) }, { 0.02d, new GammaParticle(3256000.0, 0.00038) }, { 1.9691999999999998d, new GammaParticle(511000.0, 0.00243) }, { 1.9498d, new GammaParticle(511000.0, 0.00243) }, { 0.01290507091731d, new GammaParticle(2737.0, 0.45299) }, { 0.000953508828d, new GammaParticle(2737.0, 0.45299) }, { 0.05586122469944216d, new GammaParticle(19150.0, 0.06474) }, { 0.0042758900755869925d, new GammaParticle(19150.0, 0.06474) }, { 0.008113643407185943d, new GammaParticle(19279.0, 0.06431) }, { 0.10599852884144621d, new GammaParticle(19279.0, 0.06431) }, { 0.0021804299459785414d, new GammaParticle(21736.0, 0.05704) }, { 0.02848564509389989d, new GammaParticle(21736.0, 0.05704) }, { 0.033100319599111666d, new GammaParticle(21875.0, 0.05668) }, { 0.002533659597227065d, new GammaParticle(21875.0, 0.05668) }, { 0.0003532296512485237d, new GammaParticle(22072.0, 0.05617) }, { 0.004614674505211782d, new GammaParticle(22072.0, 0.05617) } } },
            { 0.018000000000000002d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Technetium93() }, { 1.0d, new ProtonParticle() } } },

        };
    }
}
    