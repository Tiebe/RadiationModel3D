using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium245 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium245";
        public override double halfLife { get; } = 7380.0d;
        public override double atomicWeight { get; } = 245.06645d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Curium245() }, { 1.0d, new BetaParticle(-1, 447950.0) }, { 0.000258d, new GammaParticle(42870.0, 0.02892) }, { 0.000258d, new GammaParticle(198000.0, 0.00626) }, { 0.0015199999999999999d, new GammaParticle(240900.0, 0.00515) }, { 0.055999999999999994d, new GammaParticle(252800.0, 0.0049) }, { 0.00039d, new GammaParticle(255600.0, 0.00485) }, { 2.8e-05d, new GammaParticle(266990.0, 0.00464) }, { 0.00067d, new GammaParticle(295700.0, 0.00419) }, { 0.000291d, new GammaParticle(333500.0, 0.00372) }, { 7.000000000000001e-05d, new GammaParticle(348000.0, 0.00356) }, { 3.9e-05d, new GammaParticle(380300.0, 0.00326) }, { 0.00116d, new GammaParticle(388300.0, 0.00319) }, { 0.000286d, new GammaParticle(391000.0, 0.00317) }, { 0.000151d, new GammaParticle(643600.0, 0.00193) }, { 0.0551661521514039d, new GammaParticle(18579.0, 0.06673) }, { 0.02984233564103671d, new GammaParticle(104606.0, 0.01185) }, { 0.046723556663592784d, new GammaParticle(109286.0, 0.01134) }, { 0.01749915733885393d, new GammaParticle(123280.0, 0.01006) }, { 0.023658860722130512d, new GammaParticle(124855.0, 0.00993) }, { 0.006159703383276582d, new GammaParticle(126917.0, 0.00977) } } },

        };
    }
}
    