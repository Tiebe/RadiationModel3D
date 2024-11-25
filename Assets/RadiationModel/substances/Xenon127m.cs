using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon127m : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon127m";
        public override double halfLife { get; } = 69.2d;
        public override double atomicWeight { get; } = 126.9055d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Xenon127() }, { 0.69d, new GammaParticle(124600.0, 0.00995) }, { 0.3795d, new GammaParticle(172500.0, 0.00719) }, { 0.07528908848999999d, new GammaParticle(4540.0, 0.27309) }, { 0.147502773996212d, new GammaParticle(29458.0, 0.04209) }, { 0.2732544905450389d, new GammaParticle(29778.0, 0.04164) }, { 0.07921538467536335d, new GammaParticle(33726.0, 0.03676) }, { 0.0979102154587491d, new GammaParticle(34030.0, 0.03643) }, { 0.01869483078338575d, new GammaParticle(34414.0, 0.03603) } } },

        };
    }
}
    