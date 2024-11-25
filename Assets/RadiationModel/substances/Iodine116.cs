using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine116 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine116";
        public override double halfLife { get; } = 2.91d;
        public override double atomicWeight { get; } = 115.91689d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Antimony116() }, { 1.0d, new BetaParticle(1, 4701000.0) }, { 0.0017613000000000001d, new GammaParticle(380880.0, 0.00326) }, { 0.012654d, new GammaParticle(540210.0, 0.0023) }, { 0.0007695d, new GammaParticle(577910.0, 0.00215) }, { 0.0855d, new GammaParticle(678920.0, 0.00183) }, { 0.00042750000000000004d, new GammaParticle(681000.0, 0.00182) }, { 0.00062415d, new GammaParticle(742700.0, 0.00167) }, { 0.002565d, new GammaParticle(861840.0, 0.00144) }, { 0.0048222d, new GammaParticle(958660.0, 0.00129) }, { 0.0016416d, new GammaParticle(1132570.0, 0.00109) }, { 1.71e-05d, new GammaParticle(1219000.0, 0.00102) }, { 4.275e-05d, new GammaParticle(1360000.0, 0.00091) }, { 0.0007352999999999999d, new GammaParticle(1368100.0, 0.00091) }, { 0.00507015d, new GammaParticle(1402010.0, 0.00088) }, { 0.0008721d, new GammaParticle(1633000.0, 0.00076) }, { 7.695e-05d, new GammaParticle(1637000.0, 0.00076) }, { 1.71e-05d, new GammaParticle(1811000.0, 0.00068) }, { 0.00156465d, new GammaParticle(1903830.0, 0.00065) }, { 0.00029925d, new GammaParticle(2081000.0, 0.0006) }, { 0.0005985d, new GammaParticle(2154400.0, 0.00058) }, { 1.9340000000000002d, new GammaParticle(511000.0, 0.00243) }, { 0.0021527869874d, new GammaParticle(4135.0, 0.29984) }, { 0.005944455814672398d, new GammaParticle(27202.0, 0.04558) }, { 0.011069750120432771d, new GammaParticle(27473.0, 0.04513) }, { 0.0031679696506941913d, new GammaParticle(31093.0, 0.03988) }, { 0.003855419064894831d, new GammaParticle(31359.0, 0.03954) }, { 0.0006874494142006394d, new GammaParticle(31698.0, 0.03911) } } },

        };
    }
}
    