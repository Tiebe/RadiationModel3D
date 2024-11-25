using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium109n : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium109n";
        public override double halfLife { get; } = 282.18d;
        public override double atomicWeight { get; } = 108.90615d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Palladium109() }, { 0.56d, new GammaParticle(188900.0, 0.00656) }, { 0.0219537024d, new GammaParticle(3053.0, 0.40611) }, { 0.0751376550074929d, new GammaParticle(21020.0, 0.05898) }, { 0.14195665030699586d, new GammaParticle(21177.0, 0.05855) }, { 0.0389470894747959d, new GammaParticle(23904.0, 0.05187) }, { 0.0455680946855112d, new GammaParticle(24070.0, 0.05151) }, { 0.006621005210715303d, new GammaParticle(24297.0, 0.05103) } } },

        };
    }
}
    