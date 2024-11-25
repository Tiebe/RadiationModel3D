using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium236m : RadioactiveSubstance
    {
        public override string name { get; } = "Americium236m";
        public override double halfLife { get; } = 216.0d;
        public override double atomicWeight { get; } = 236.04948d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Plutonium236() }, { 0.138d, new GammaParticle(158350.0, 0.00783) }, { 0.2d, new GammaParticle(319500.0, 0.00388) }, { 0.132d, new GammaParticle(560300.0, 0.00221) }, { 0.308d, new GammaParticle(718600.0, 0.00173) }, { 0.304d, new GammaParticle(879700.0, 0.00141) }, { 0.078d, new GammaParticle(1021600.0, 0.00121) }, { 0.162d, new GammaParticle(1037800.0, 0.00119) }, { 0.02366d, new GammaParticle(511000.0, 0.00243) }, { 0.65d, new GammaParticle(17604.0, 0.07043) }, { 0.31d, new GammaParticle(99533.0, 0.01246) }, { 0.48d, new GammaParticle(103741.0, 0.01195) }, { 0.18d, new GammaParticle(117130.0, 0.01059) }, { 0.24d, new GammaParticle(118619.0, 0.01045) }, { 0.062d, new GammaParticle(120544.0, 0.01029) } } },
            { 4e-05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Neptunium232() }, { 1.0d, new AlphaParticle(7327002.09) } } },

        };
    }
}
    