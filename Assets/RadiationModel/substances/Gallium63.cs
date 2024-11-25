using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium63 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium63";
        public override double halfLife { get; } = 32.1d;
        public override double atomicWeight { get; } = 62.93929d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Copper63() }, { 1.0d, new BetaParticle(1, 4516400.0) }, { 0.057999999999999996d, new GammaParticle(193000.0, 0.00642) }, { 0.035d, new GammaParticle(247900.0, 0.005) }, { 0.0039000000000000003d, new GammaParticle(389800.0, 0.00318) }, { 0.0029d, new GammaParticle(415000.0, 0.00299) }, { 0.0060999999999999995d, new GammaParticle(457900.0, 0.00271) }, { 0.10400000000000001d, new GammaParticle(627100.0, 0.00198) }, { 0.113d, new GammaParticle(637000.0, 0.00195) }, { 0.05d, new GammaParticle(650000.0, 0.00191) }, { 0.022000000000000002d, new GammaParticle(768500.0, 0.00161) }, { 0.0026d, new GammaParticle(1054600.0, 0.00118) }, { 0.023d, new GammaParticle(1065200.0, 0.00116) }, { 0.0034999999999999996d, new GammaParticle(1147000.0, 0.00108) }, { 0.0027d, new GammaParticle(1203400.0, 0.00103) }, { 0.042d, new GammaParticle(1395400.0, 0.00089) }, { 0.0033d, new GammaParticle(1498500.0, 0.00083) }, { 0.031d, new GammaParticle(1691700.0, 0.00073) }, { 1.982d, new GammaParticle(511000.0, 0.00243) }, { 0.00012d, new GammaParticle(1035.0, 1.19791) }, { 0.00115d, new GammaParticle(8616.0, 0.1439) }, { 0.0022d, new GammaParticle(8639.0, 0.14352) }, { 0.00048d, new GammaParticle(9610.0, 0.12902) }, { 0.00048d, new GammaParticle(9610.0, 0.12902) } } },

        };
    }
}
    