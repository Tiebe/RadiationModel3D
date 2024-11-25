using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium50m : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium50m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 49.97256d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Potassium50() }, { 0.451d, new GammaParticle(128100.0, 0.00968) }, { 0.55d, new GammaParticle(172000.0, 0.00721) }, { 0.000164742400086d, new GammaParticle(311.0, 3.98663) }, { 0.0022372996813317756d, new GammaParticle(3311.0, 0.37446) }, { 0.004425914305305194d, new GammaParticle(3314.0, 0.37412) }, { 0.0008162437133630289d, new GammaParticle(3591.0, 0.34526) }, { 0.0008162437133630289d, new GammaParticle(3591.0, 0.34526) } } },

        };
    }
}
    