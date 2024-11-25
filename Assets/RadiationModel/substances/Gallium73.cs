using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium73 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium73";
        public override double halfLife { get; } = 17496.0d;
        public override double atomicWeight { get; } = 72.92517d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Germanium73() }, { 1.0d, new BetaParticle(-1, 799115.0) }, { 0.1047d, new GammaParticle(53450.0, 0.0232) }, { 0.004d, new GammaParticle(68700.0, 0.01805) }, { 0.00096d, new GammaParticle(216300.0, 0.00573) }, { 0.0032d, new GammaParticle(284900.0, 0.00435) }, { 0.7979999999999999d, new GammaParticle(297320.0, 0.00417) }, { 0.11199999999999999d, new GammaParticle(325700.0, 0.00381) }, { 0.0021d, new GammaParticle(351000.0, 0.00353) }, { 0.0049d, new GammaParticle(379200.0, 0.00327) }, { 0.0036d, new GammaParticle(488200.0, 0.00254) }, { 0.0015d, new GammaParticle(501600.0, 0.00247) }, { 0.003d, new GammaParticle(541700.0, 0.00229) }, { 0.0018d, new GammaParticle(561800.0, 0.00221) }, { 0.0015d, new GammaParticle(577200.0, 0.00215) }, { 0.042d, new GammaParticle(739420.0, 0.00168) }, { 0.0144d, new GammaParticle(767800.0, 0.00161) }, { 0.0014000000000000002d, new GammaParticle(993600.0, 0.00125) }, { 0.0128d, new GammaParticle(1065100.0, 0.00116) }, { 0.014870448978d, new GammaParticle(1221.0, 1.01543) }, { 0.12152106887588157d, new GammaParticle(9856.0, 0.1258) }, { 0.23600906753909803d, new GammaParticle(9887.0, 0.1254) }, { 0.05278991935911979d, new GammaParticle(11026.0, 0.11245) }, { 0.05395129758502042d, new GammaParticle(11038.0, 0.11232) }, { 0.0011613782259006355d, new GammaParticle(11099.0, 0.11171) } } },

        };
    }
}
    