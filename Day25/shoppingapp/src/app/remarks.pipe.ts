import { Pipe, PipeTransform } from '@angular/core';
import { DomSanitizer } from '@angular/platform-browser';

@Pipe({
  name: 'remarks'
})
export class RemarksPipe implements PipeTransform {
  constructor(private sanitizer:DomSanitizer){}

  transform(value: unknown, ...args: unknown[]): unknown {
    // var count = (args[0]??10 as number);
    // return (value as string).substring(0,count as number)+"...";
    // var result= document.createElement("div")
    // result.innerHTML = "Hello <br/> Welcome";
    var res:string = "Hello &lt;br\&gt; Welcome";
    //console.log(result.innerHTML)
    return this.sanitizer.bypassSecurityTrustHtml(res);
  }

}
