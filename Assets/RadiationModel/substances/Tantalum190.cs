using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum190 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum190";
        public override double halfLife { get; } = 5.3d;
        public override double atomicWeight { get; } = 189.96917d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tungsten190() }, { 1.0d, new BetaParticle(-1, 2825000.0) }, { 0.6565000000000001d, new GammaParticle(207000.0, 0.00599) }, { 0.3575d, new GammaParticle(247000.0, 0.00502) }, { 0.195d, new GammaParticle(357000.0, 0.00347) }, { 0.156d, new GammaParticle(454000.0, 0.00273) }, { 0.0654304171625d, new GammaParticle(9740.0, 0.12729) }, { 0.050273229966302097d, new GammaParticle(57983.0, 0.02138) }, { 0.08732539511256227d, new GammaParticle(59320.0, 0.0209) }, { 0.0289453936586622d, new GammaParticle(67335.0, 0.01841) }, { 0.03687643152113564d, new GammaParticle(68117.0, 0.0182) }, { 0.007931037862473442d, new GammaParticle(69068.0, 0.01795) } } },

        };
    }
}
    