using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium130 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium130";
        public override double halfLife { get; } = 0.162d;
        public override double atomicWeight { get; } = 129.93439d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Indium130() }, { 1.0d, new BetaParticle(-1, 4394250.0) }, { 0.022400000000000003d, new GammaParticle(388700.0, 0.00319) }, { 0.49616d, new GammaParticle(451000.0, 0.00275) }, { 0.12376d, new GammaParticle(949900.0, 0.00131) }, { 0.0308d, new GammaParticle(1015500.0, 0.00122) }, { 0.009519999999999999d, new GammaParticle(1138400.0, 0.00109) }, { 0.11199999999999999d, new GammaParticle(1170300.0, 0.00106) }, { 0.013999999999999999d, new GammaParticle(1314400.0, 0.00094) }, { 0.56d, new GammaParticle(1669200.0, 0.00074) }, { 0.02464d, new GammaParticle(1731800.0, 0.00072) }, { 0.06216d, new GammaParticle(2120100.0, 0.00058) }, { 0.00728d, new GammaParticle(2585500.0, 0.00048) }, { 0.00728d, new GammaParticle(2738300.0, 0.00045) }, { 0.00616d, new GammaParticle(2804900.0, 0.00044) }, { 0.0028000000000000004d, new GammaParticle(4407000.0, 0.00028) }, { 0.00336d, new GammaParticle(4631000.0, 0.00027) }, { 0.00616d, new GammaParticle(5098000.0, 0.00024) }, { 0.00392d, new GammaParticle(5196000.0, 0.00024) }, { 0.0022400000000000002d, new GammaParticle(5391000.0, 0.00023) } } },
            { 0.035d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Indium130() }, { 1.0d, new BetaParticle(-1, 4394250.0) }, { 0.022400000000000003d, new GammaParticle(388700.0, 0.00319) }, { 0.49616d, new GammaParticle(451000.0, 0.00275) }, { 0.12376d, new GammaParticle(949900.0, 0.00131) }, { 0.0308d, new GammaParticle(1015500.0, 0.00122) }, { 0.009519999999999999d, new GammaParticle(1138400.0, 0.00109) }, { 0.11199999999999999d, new GammaParticle(1170300.0, 0.00106) }, { 0.013999999999999999d, new GammaParticle(1314400.0, 0.00094) }, { 0.56d, new GammaParticle(1669200.0, 0.00074) }, { 0.02464d, new GammaParticle(1731800.0, 0.00072) }, { 0.06216d, new GammaParticle(2120100.0, 0.00058) }, { 0.00728d, new GammaParticle(2585500.0, 0.00048) }, { 0.00728d, new GammaParticle(2738300.0, 0.00045) }, { 0.00616d, new GammaParticle(2804900.0, 0.00044) }, { 0.0028000000000000004d, new GammaParticle(4407000.0, 0.00028) }, { 0.00336d, new GammaParticle(4631000.0, 0.00027) }, { 0.00616d, new GammaParticle(5098000.0, 0.00024) }, { 0.00392d, new GammaParticle(5196000.0, 0.00024) }, { 0.0022400000000000002d, new GammaParticle(5391000.0, 0.00023) } } },

        };
    }
}
    