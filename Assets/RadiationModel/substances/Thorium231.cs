using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium231 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium231";
        public override double halfLife { get; } = 92052.0d;
        public override double atomicWeight { get; } = 231.0363d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Protactinium231() }, { 1.0d, new BetaParticle(-1, 195750.0) }, { 0.0028000000000000004d, new GammaParticle(17195.0, 0.0721) }, { 0.00095d, new GammaParticle(18055.0, 0.06867) }, { 0.1374d, new GammaParticle(25650.0, 0.04834) }, { 0.000605d, new GammaParticle(42810.0, 0.02896) }, { 7.5e-06d, new GammaParticle(44080.0, 0.02813) }, { 0.0048d, new GammaParticle(53200.0, 0.02331) }, { 0.00471d, new GammaParticle(58570.0, 0.02117) }, { 0.00023d, new GammaParticle(63860.0, 0.01942) }, { 5.9800000000000003e-05d, new GammaParticle(68500.0, 0.0181) }, { 0.0026d, new GammaParticle(72751.0, 0.01704) }, { 6.8e-05d, new GammaParticle(73000.0, 0.01698) }, { 4.3e-05d, new GammaParticle(77690.0, 0.01596) }, { 0.00904d, new GammaParticle(81228.0, 0.01526) }, { 0.00422d, new GammaParticle(82087.0, 0.0151) }, { 0.068d, new GammaParticle(84214.0, 0.01472) }, { 0.0102d, new GammaParticle(89950.0, 0.01378) }, { 0.00048d, new GammaParticle(93020.0, 0.01333) }, { 0.00135d, new GammaParticle(99278.0, 0.01249) }, { 0.00449d, new GammaParticle(102270.0, 0.01212) }, { 8e-05d, new GammaParticle(105790.0, 0.01172) }, { 0.000182d, new GammaParticle(106610.0, 0.01163) }, { 1.02e-05d, new GammaParticle(115630.0, 0.01072) }, { 0.000228d, new GammaParticle(116830.0, 0.01061) }, { 0.000598d, new GammaParticle(124927.0, 0.00992) }, { 0.000258d, new GammaParticle(134030.0, 0.00925) }, { 0.000809d, new GammaParticle(135670.0, 0.00914) }, { 4.49e-05d, new GammaParticle(136750.0, 0.00907) }, { 7.5e-06d, new GammaParticle(140540.0, 0.00882) }, { 5.92e-05d, new GammaParticle(145060.0, 0.00855) }, { 0.00032599999999999996d, new GammaParticle(145940.0, 0.0085) }, { 0.00158d, new GammaParticle(163101.0, 0.0076) }, { 3.54e-05d, new GammaParticle(165000.0, 0.00751) }, { 1.36e-05d, new GammaParticle(169650.0, 0.00731) }, { 0.000182d, new GammaParticle(174150.0, 0.00712) }, { 6.499999999999999e-07d, new GammaParticle(177660.0, 0.00698) }, { 0.00034d, new GammaParticle(183489.0, 0.00676) }, { 3.33e-05d, new GammaParticle(188760.0, 0.00657) }, { 0.00040800000000000005d, new GammaParticle(217940.0, 0.00569) }, { 9.499999999999999e-05d, new GammaParticle(236040.0, 0.00525) }, { 3.06e-06d, new GammaParticle(240270.0, 0.00516) }, { 8.599999999999999e-06d, new GammaParticle(242510.0, 0.00511) }, { 8.2e-06d, new GammaParticle(249600.0, 0.00497) }, { 6.8e-06d, new GammaParticle(250450.0, 0.00495) }, { 1.48e-05d, new GammaParticle(267720.0, 0.00463) }, { 3.5e-07d, new GammaParticle(274100.0, 0.00452) }, { 4.4e-06d, new GammaParticle(308780.0, 0.00402) }, { 3.2e-05d, new GammaParticle(311000.0, 0.00399) }, { 1.02e-06d, new GammaParticle(317870.0, 0.0039) }, { 1.6000000000000001e-06d, new GammaParticle(320150.0, 0.00387) }, { 6.8e-07d, new GammaParticle(351800.0, 0.00352) }, { 0.56d, new GammaParticle(16228.0, 0.0764) }, { 0.0034999999999999996d, new GammaParticle(92282.0, 0.01344) }, { 0.005600000000000001d, new GammaParticle(95865.0, 0.01293) }, { 0.00199d, new GammaParticle(108373.0, 0.01144) }, { 0.0027d, new GammaParticle(109740.0, 0.0113) }, { 0.00067d, new GammaParticle(111482.0, 0.01112) } } },

        };
    }
}
    