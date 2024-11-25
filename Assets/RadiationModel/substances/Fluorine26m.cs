using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fluorine26m : RadioactiveSubstance
    {
        public override string name { get; } = "Fluorine26m";
        public override double halfLife { get; } = 0.0022d;
        public override double atomicWeight { get; } = 26.02073d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.82d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Fluorine26() }, { 0.34d, new GammaParticle(643400.0, 0.00193) } } },
            { 0.18d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neon26() }, { 1.0d, new BetaParticle(-1, 9414500.0) }, { 0.023d, new GammaParticle(1499100.0, 0.00083) }, { 0.003d, new GammaParticle(1843400.0, 0.00067) } } },
            { 0.12d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neon26() }, { 1.0d, new BetaParticle(-1, 9414500.0) }, { 0.023d, new GammaParticle(1499100.0, 0.00083) }, { 0.003d, new GammaParticle(1843400.0, 0.00067) } } },

        };
    }
}
    