using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium69m : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium69m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 68.92806d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Germanium69() }, { 0.441d, new GammaParticle(85000.0, 0.01459) }, { 0.01019537316d, new GammaParticle(1221.0, 1.01543) }, { 0.08391016510992977d, new GammaParticle(9856.0, 0.1258) }, { 0.16296400293247185d, new GammaParticle(9887.0, 0.1254) }, { 0.036451381563207826d, new GammaParticle(11026.0, 0.11245) }, { 0.0372533119575984d, new GammaParticle(11038.0, 0.11232) }, { 0.0008019303943905721d, new GammaParticle(11099.0, 0.11171) } } },

        };
    }
}
    