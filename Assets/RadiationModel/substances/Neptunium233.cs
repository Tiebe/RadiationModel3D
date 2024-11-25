using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium233 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium233";
        public override double halfLife { get; } = 2172.0d;
        public override double atomicWeight { get; } = 233.04074d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Uranium233() }, { 9.1e-06d, new GammaParticle(28562.0, 0.04341) }, { 1.61e-06d, new GammaParticle(41660.0, 0.02976) }, { 0.00023099999999999998d, new GammaParticle(205300.0, 0.00604) }, { 0.000357d, new GammaParticle(226000.0, 0.00549) }, { 0.000413d, new GammaParticle(228570.0, 0.00542) }, { 0.00154d, new GammaParticle(234300.0, 0.00529) }, { 0.00084d, new GammaParticle(242500.0, 0.00511) }, { 0.000399d, new GammaParticle(247600.0, 0.00501) }, { 7.49e-06d, new GammaParticle(248370.0, 0.00499) }, { 0.00042d, new GammaParticle(256000.0, 0.00484) }, { 0.00098d, new GammaParticle(258500.0, 0.0048) }, { 5.88e-05d, new GammaParticle(271556.0, 0.00457) }, { 0.00133d, new GammaParticle(280500.0, 0.00442) }, { 0.00504d, new GammaParticle(298810.0, 0.00415) }, { 0.0008119999999999999d, new GammaParticle(300128.0, 0.00413) }, { 0.006999999999999999d, new GammaParticle(312100.0, 0.00397) }, { 0.000693d, new GammaParticle(321000.0, 0.00386) }, { 0.000553d, new GammaParticle(340700.0, 0.00364) }, { 0.00017500000000000003d, new GammaParticle(393000.0, 0.00315) }, { 0.000581d, new GammaParticle(425600.0, 0.00291) }, { 0.000413d, new GammaParticle(504800.0, 0.00246) }, { 0.00154d, new GammaParticle(506500.0, 0.00245) }, { 0.0028000000000000004d, new GammaParticle(546900.0, 0.00227) }, { 0.00028000000000000003d, new GammaParticle(557100.0, 0.00223) }, { 0.00026599999999999996d, new GammaParticle(597700.0, 0.00207) }, { 7.7e-05d, new GammaParticle(644400.0, 0.00192) }, { 0.000168d, new GammaParticle(665900.0, 0.00186) }, { 0.396743940715832d, new GammaParticle(16678.0, 0.07434) }, { 0.22041020467176822d, new GammaParticle(94657.0, 0.0131) }, { 0.3528256838030546d, new GammaParticle(98439.0, 0.0126) }, { 0.1272908306747371d, new GammaParticle(111238.0, 0.01115) }, { 0.1708242947654972d, new GammaParticle(112645.0, 0.01101) }, { 0.04353346409076009d, new GammaParticle(114446.0, 0.01083) } } },
            { 7e-06d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Protactinium229() }, { 1.0d, new AlphaParticle(6650002.09) } } },

        };
    }
}
    