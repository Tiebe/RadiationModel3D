using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead202m : RadioactiveSubstance
    {
        public override string name { get; } = "Lead202m";
        public override double halfLife { get; } = 12744.0d;
        public override double atomicWeight { get; } = 201.97448d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.903d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead202() }, { 0.0054d, new GammaParticle(124750.0, 0.00994) }, { 0.00039d, new GammaParticle(129100.0, 0.0096) }, { 0.0025d, new GammaParticle(240180.0, 0.00516) }, { 0.00032d, new GammaParticle(291930.0, 0.00425) }, { 0.0039000000000000003d, new GammaParticle(417300.0, 0.00297) }, { 0.84d, new GammaParticle(422120.0, 0.00294) }, { 0.00055d, new GammaParticle(532340.0, 0.00233) }, { 0.0012d, new GammaParticle(547600.0, 0.00226) }, { 0.318d, new GammaParticle(657490.0, 0.00189) }, { 0.00073d, new GammaParticle(662550.0, 0.00187) }, { 0.49d, new GammaParticle(786990.0, 0.00158) }, { 0.0098d, new GammaParticle(954500.0, 0.0013) }, { 0.9009999999999999d, new GammaParticle(960700.0, 0.00129) }, { 3.2000000000000003e-06d, new GammaParticle(1382800.0, 0.0009) }, { 0.09205902484465778d, new GammaParticle(12522.0, 0.09901) }, { 0.021174028687856863d, new GammaParticle(72805.0, 0.01703) }, { 0.035586602836734225d, new GammaParticle(74970.0, 0.01654) }, { 0.012162992469555234d, new GammaParticle(84986.0, 0.01459) }, { 0.015836216195360915d, new GammaParticle(86022.0, 0.01441) }, { 0.0036732237258056805d, new GammaParticle(87301.0, 0.0142) } } },
            { 0.09699999999999999d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Mercury202() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) }, { 0.0023d, new GammaParticle(148550.0, 0.00835) }, { 0.0077d, new GammaParticle(211920.0, 0.00585) }, { 0.0087d, new GammaParticle(241100.0, 0.00514) }, { 0.0023d, new GammaParticle(335550.0, 0.00369) }, { 0.063d, new GammaParticle(389940.0, 0.00318) }, { 0.08900000000000001d, new GammaParticle(459720.0, 0.0027) }, { 0.094d, new GammaParticle(490470.0, 0.00253) }, { 0.0060999999999999995d, new GammaParticle(601950.0, 0.00206) }, { 0.04147446413061599d, new GammaParticle(12148.0, 0.10206) }, { 0.030292854739291594d, new GammaParticle(70832.0, 0.0175) }, { 0.05113581151129573d, new GammaParticle(72874.0, 0.01701) }, { 0.01739070204426576d, new GammaParticle(82629.0, 0.015) }, { 0.022555740551412688d, new GammaParticle(83631.0, 0.01483) }, { 0.00516503850714693d, new GammaParticle(84866.0, 0.01461) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    