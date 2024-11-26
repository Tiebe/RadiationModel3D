using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium231 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium231";
        public override double halfLife { get; } = 362880.0d;
        public override double atomicWeight { get; } = 231.03629d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Protactinium231()), new(1e-05d, new GammaParticle(17195.0, 0.0721)), new(0.0026d, new GammaParticle(18055.0, 0.06867)), new(0.146d, new GammaParticle(25650.0, 0.04834)), new(0.005d, new GammaParticle(58570.0, 0.02117)), new(5.77e-05d, new GammaParticle(68500.0, 0.0181)), new(0.00010999999999999999d, new GammaParticle(72751.0, 0.01704)), new(4.1599999999999995e-05d, new GammaParticle(77690.0, 0.01596)), new(0.000234d, new GammaParticle(81228.0, 0.01526)), new(0.00018999999999999998d, new GammaParticle(82087.0, 0.0151)), new(0.073d, new GammaParticle(84214.0, 0.01472)), new(0.00042d, new GammaParticle(89950.0, 0.01378)), new(0.00131d, new GammaParticle(93020.0, 0.01333)), new(3.65e-05d, new GammaParticle(99278.0, 0.01249)), new(0.0126d, new GammaParticle(102270.0, 0.01212)), new(0.00042d, new GammaParticle(136750.0, 0.00907)), new(0.000146d, new GammaParticle(171430.0, 0.00723)), new(3.9e-06d, new GammaParticle(189500.0, 0.00654)), new(3.9e-06d, new GammaParticle(196000.0, 0.00633)), new(0.003d, new GammaParticle(217940.0, 0.00569)), new(0.00089d, new GammaParticle(236040.0, 0.00525)), new(9.6e-06d, new GammaParticle(240270.0, 0.00516)), new(8.099999999999999e-05d, new GammaParticle(242510.0, 0.00511)), new(0.00020400000000000003d, new GammaParticle(264550.0, 0.00469)), new(0.000453d, new GammaParticle(273710.0, 0.00453)), new(1.42e-05d, new GammaParticle(308780.0, 0.00402)), new(0.00027d, new GammaParticle(311000.0, 0.00399)), new(3.1e-06d, new GammaParticle(317870.0, 0.0039)), new(1.15e-05d, new GammaParticle(320150.0, 0.00387)), new(0.96d, new GammaParticle(16228.0, 0.0764)), new(0.18303259476912703d, new GammaParticle(92282.0, 0.01344)), new(0.29454875244468465d, new GammaParticle(95865.0, 0.01293)), new(0.10557436801739228d, new GammaParticle(108373.0, 0.01144)), new(0.14136407877528825d, new GammaParticle(109740.0, 0.0113)), new(0.035789710757895984d, new GammaParticle(111482.0, 0.01112)) } },
            { 4e-05d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Thorium227()), new(1.0d, new AlphaParticle(6598202.09)), new(8.3e-11d, new GammaParticle(9300.0, 0.13332)), new(4.4000000000000004e-08d, new GammaParticle(15200.0, 0.08157)), new(3.8e-08d, new GammaParticle(24330.0, 0.05096)), new(4.8e-08d, new GammaParticle(28570.0, 0.0434)), new(5.0000000000000004e-08d, new GammaParticle(37900.0, 0.03271)), new(1.5000000000000002e-08d, new GammaParticle(39880.0, 0.03109)), new(7.999999999999999e-09d, new GammaParticle(42090.0, 0.02946)), new(1.5000000000000002e-08d, new GammaParticle(51850.0, 0.02391)), new(1.6e-07d, new GammaParticle(53230.0, 0.02329)), new(5.8e-08d, new GammaParticle(56410.0, 0.02198)), new(5.8e-09d, new GammaParticle(58100.0, 0.02134)), new(2.5e-09d, new GammaParticle(60600.0, 0.02046)), new(3.8e-08d, new GammaParticle(61330.0, 0.02022)), new(7.5e-08d, new GammaParticle(64380.0, 0.01926)), new(6.000000000000001e-08d, new GammaParticle(66940.0, 0.01852)), new(1.9e-07d, new GammaParticle(68330.0, 0.01814)), new(2.5000000000000002e-08d, new GammaParticle(72140.0, 0.01719)), new(1.9e-08d, new GammaParticle(72780.0, 0.01704)), new(2.3e-08d, new GammaParticle(74850.0, 0.01656)), new(1.5000000000000002e-08d, new GammaParticle(77520.0, 0.01599)), new(4.8e-08d, new GammaParticle(89880.0, 0.01379)), new(1.2e-08d, new GammaParticle(99090.0, 0.01251)), new(4e-08d, new GammaParticle(102930.0, 0.01205)), new(7.700000000000001e-09d, new GammaParticle(111100.0, 0.01116)), new(1.8e-08d, new GammaParticle(117980.0, 0.01051)), new(1.4e-08d, new GammaParticle(124800.0, 0.00993)), new(7.999999999999999e-09d, new GammaParticle(150700.0, 0.00823)), new(1.5000000000000002e-08d, new GammaParticle(157790.0, 0.00786)), new(1.5000000000000002e-08d, new GammaParticle(159390.0, 0.00778)), new(4.2e-09d, new GammaParticle(189900.0, 0.00653)), new(1.2e-08d, new GammaParticle(190620.0, 0.0065)), new(7.999999999999999e-09d, new GammaParticle(204200.0, 0.00607)), new(9e-09d, new GammaParticle(211400.0, 0.00586)), new(5.2e-09d, new GammaParticle(219600.0, 0.00565)), new(1.3e-09d, new GammaParticle(241200.0, 0.00514)), new(3.3e-09d, new GammaParticle(242700.0, 0.00511)), new(6.9e-08d, new GammaParticle(264660.0, 0.00468)), new(3.6e-08d, new GammaParticle(279760.0, 0.00443)), new(3.1e-08d, new GammaParticle(289010.0, 0.00429)), new(5.8e-09d, new GammaParticle(294500.0, 0.00421)), new(2.3e-08d, new GammaParticle(309680.0, 0.004)), new(8.39042929341008e-06d, new GammaParticle(15784.0, 0.07855)), new(1.030010017056332e-07d, new GammaParticle(89954.0, 0.01378)), new(1.6661436704243478e-07d, new GammaParticle(93347.0, 0.01328)), new(5.9287149148789825e-08d, new GammaParticle(105566.0, 0.01174)), new(7.926691841193199e-08d, new GammaParticle(106894.0, 0.0116)), new(1.9979769263142167e-08d, new GammaParticle(108580.0, 0.01142)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    