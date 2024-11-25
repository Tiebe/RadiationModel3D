using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum180 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum180";
        public override double halfLife { get; } = 29354.4d;
        public override double atomicWeight { get; } = 179.94747d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.85d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Hafnium180() }, { 0.0451d, new GammaParticle(93324.0, 0.01329) }, { 0.224529618391d, new GammaParticle(9114.0, 0.13604) }, { 0.20346604669587054d, new GammaParticle(54608.0, 0.0227) }, { 0.3560833858870678d, new GammaParticle(55786.0, 0.02222) }, { 0.11747446650912519d, new GammaParticle(63333.0, 0.01958) }, { 0.14884014906706158d, new GammaParticle(64057.0, 0.01936) }, { 0.031365682557936425d, new GammaParticle(64935.0, 0.01909) } } },
            { 0.15d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tungsten180() }, { 1.0d, new BetaParticle(-1, 351300.0) }, { 0.0087d, new GammaParticle(103600.0, 0.01197) }, { 0.006454272045d, new GammaParticle(9740.0, 0.12729) }, { 0.001975382106655717d, new GammaParticle(57983.0, 0.02138) }, { 0.0034312699438174693d, new GammaParticle(59320.0, 0.0209) }, { 0.0011373490969598223d, new GammaParticle(67335.0, 0.01841) }, { 0.0014489827495268138d, new GammaParticle(68117.0, 0.0182) }, { 0.00031163365256699135d, new GammaParticle(69068.0, 0.01795) } } },

        };
    }
}
    