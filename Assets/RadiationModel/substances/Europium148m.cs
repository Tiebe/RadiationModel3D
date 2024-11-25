using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium148m : RadioactiveSubstance
    {
        public override string name { get; } = "Europium148m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 147.91886d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Europium148() }, { 2.47e-05d, new GammaParticle(12000.0, 0.10332) }, { 0.0068000000000000005d, new GammaParticle(190000.0, 0.00653) }, { 0.0068000000000000005d, new GammaParticle(201900.0, 0.00614) }, { 0.0047599999999999995d, new GammaParticle(206300.0, 0.00601) }, { 0.6188d, new GammaParticle(232800.0, 0.00533) }, { 0.01972d, new GammaParticle(285700.0, 0.00434) }, { 0.2584d, new GammaParticle(312200.0, 0.00397) }, { 0.2924d, new GammaParticle(396200.0, 0.00313) }, { 0.68d, new GammaParticle(475600.0, 0.00261) }, { 0.14854634522784d, new GammaParticle(6603.0, 0.18777) }, { 0.03266127639415726d, new GammaParticle(40901.0, 0.03031) }, { 0.058934096705444354d, new GammaParticle(41541.0, 0.02985) }, { 0.01856662968235168d, new GammaParticle(47146.0, 0.0263) }, { 0.023356820140398412d, new GammaParticle(47645.0, 0.02602) }, { 0.004790190458046733d, new GammaParticle(48248.0, 0.0257) } } },

        };
    }
}
    