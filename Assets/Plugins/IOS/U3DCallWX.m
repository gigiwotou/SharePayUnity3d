//
//  U3DCallWX.m
//  SDKSample
//
//  Created by ghostheart on 17/8/1.
//
//

#import "U3DCallWX.h"
#import "WXApiManager.h"
#import "WXApiRequestHandler.h"
#import "Constant.h"


@implementation U3DCallWX
void registerApp(char *appid)
{
    NSString *strappid = [NSString stringWithUTF8String:appid];
    //向微信注册
    [WXApi registerApp:strappid enableMTA:YES];
    
    //向微信注册支持的文件类型
    UInt64 typeFlag = MMAPP_SUPPORT_TEXT | MMAPP_SUPPORT_PICTURE | MMAPP_SUPPORT_LOCATION | MMAPP_SUPPORT_VIDEO |MMAPP_SUPPORT_AUDIO | MMAPP_SUPPORT_WEBPAGE | MMAPP_SUPPORT_DOC | MMAPP_SUPPORT_DOCX | MMAPP_SUPPORT_PPT | MMAPP_SUPPORT_PPTX | MMAPP_SUPPORT_XLS | MMAPP_SUPPORT_XLSX | MMAPP_SUPPORT_PDF;
    
    [WXApi registerAppSupportContentFlag:typeFlag];
}
void sendURLToSS(NSString *url, NSString *title, NSString *describe)
{
    UIImage *thumbImage = [UIImage imageNamed:@"152x152.png"];
    [WXApiRequestHandler sendLinkURL:url
                             TagName:@"ShareToWX"
                               Title:title
                         Description:describe
                          ThumbImage:thumbImage
                             InScene:WXSceneSession];}
void sendAppToSS(NSString *title, NSString *describe)
{
    Byte* pBuffer = (Byte *)malloc(BUFFER_SIZE);
    memset(pBuffer, 0, BUFFER_SIZE);
    NSData* data = [NSData dataWithBytes:pBuffer length:BUFFER_SIZE];
    free(pBuffer);

    UIImage *thumbImage = [UIImage imageNamed:@"152x152.png"];
    [WXApiRequestHandler sendAppContentData:data
                                ExtInfo:kAppContentExInfo
                                 ExtURL:kAppContnetExURL
                                  Title:title
                            Description:describe
                             MessageExt:kAppMessageExt
                          MessageAction:kAppMessageAction
                             ThumbImage:thumbImage
                                InScene:WXSceneSession];}


@end
