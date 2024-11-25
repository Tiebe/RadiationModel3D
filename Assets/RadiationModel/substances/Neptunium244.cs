using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium244 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium244";
        public override double halfLife { get; } = 137.4d;
        public override double atomicWeight { get; } = 244.06789d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Plutonium244() }, { 1.0d, new BetaParticle(-1, 1717000.0) }, { 0.34d, new GammaParticle(162900.0, 0.00761) }, { 0.3876d, new GammaParticle(217100.0, 0.00571) }, { 0.37060000000000004d, new GammaParticle(681000.0, 0.00182) }, { 0.34292172633805995d, new GammaParticle(17604.0, 0.07043) }, { 0.03413745320801865d, new GammaParticle(99533.0, 0.01246) }, { 0.05404060979581866d, new GammaParticle(103741.0, 0.01195) }, { 0.019835154484159394d, new GammaParticle(117130.0, 0.01059) }, { 0.026717953090162703d, new GammaParticle(118619.0, 0.01045) }, { 0.00688279860600331d, new GammaParticle(120544.0, 0.01029) } } },

        };
    }
}
    